﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KainmunityServer.DataAccess;
using KainmunityServer.Models;

namespace KainmunityServer.Controllers
{
    [Route("api/donations")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        [HttpPost("contribute")]
        public async Task<JsonResult> ContributeDonation(DonationItem donationItem)
        {
            var isSuccess = await DonationsManager.AddDonation(donationItem);
            return new JsonResult(isSuccess ? Ok() : Unauthorized());
        }

        [HttpGet("request")]
        public async Task<JsonResult> GetRequests()
        {
            var res = await DonationsManager.GetRequests();
            return new JsonResult(Ok(res)); 
        }

        [HttpGet("request/{donationId}")]
        public async Task<JsonResult> GetAssociatedRequests(int donationId)
        {
            var donationDetails = await DonationsManager.GetDonationDetails(donationId);
            var requests = await DonationsManager.GetAssociatedRequests(donationId);

            return new JsonResult(new
            {
                statusCode = StatusCodes.Status200OK,
                details = donationDetails,
                requests = requests,
            });
        }

        [HttpGet("pending")]
        public async Task<JsonResult> GetPendingDonations()
        {
            var pendingDonations = await DonationsManager.GetPendingDonations();

            return new JsonResult(new
            {
                statusCode = StatusCodes.Status200OK,
                value = pendingDonations
            });
        }

        [HttpPost("request")]
        public async Task<JsonResult> RequestDonation(DonationRequest[] donationRequests)
        {
            if (!Request.Headers.TryGetValue("User-Id", out var headerValue))
            {
                return new JsonResult(BadRequest());
            }

            int userId = Convert.ToInt32(headerValue[0]);

            for (int i = 0; i < donationRequests.Length; i++)
            {
                donationRequests[i].RequesterId = userId;
                donationRequests[i].Status = "Pending";
            }

            var isSuccess = await DonationsManager.MakeRequest(donationRequests);
            return new JsonResult(isSuccess ? Ok() : Unauthorized());
        }

        [HttpPut("request")]
        public async Task<JsonResult> UpdateRequests(DonationRequest[] donationRequests)
        {
            var isSuccess = await DonationsManager.UpdateRequests(donationRequests);
            return new JsonResult(isSuccess ? Ok() : Unauthorized());
        }

        [HttpGet("available/{UserId}")]
        public async Task<JsonResult> GetAvailableDonations(int UserId)
        {
            var donations = await DonationsManager.GetAvailable(UserId);
            return new JsonResult(Ok(donations));
        }

        [HttpGet("leaderboard")]
        public async Task<JsonResult> GetLeaderboard()
        {
            var donations = await DonationsManager.FetchLeaderboard();
            return new JsonResult(Ok(donations));
        }

        [HttpGet("accept/{donationId}")]
        public async Task<JsonResult> AcceptDonation(int donationId)
        {
            var donations = await DonationsManager.AcceptDonation(donationId);
            return new JsonResult(Ok(donations));
        }
    }
}
