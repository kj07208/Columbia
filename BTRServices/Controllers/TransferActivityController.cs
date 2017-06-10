﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BTRServices.DAL;
using Swashbuckle.Swagger.Annotations;
using BTRServices.Models;
using BTRServices.Repository;

namespace BTRServices.Controllers
{
    public class TransferActivityController : ApiController
    {
        private BtrDbContext db = new BtrDbContext();

        [HttpGet]
        [ActionName("ItemsByBtrId")]
        [SwaggerOperation("ItemsByBtrId")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]

        public IHttpActionResult ItemsByBtrId(int btr_key)
        {
            try
            {
                TransferActivityRepository ta = new TransferActivityRepository(db);
                return Ok(ta.ItemsByBtrId(btr_key));
            }
            catch (Exception exError)
            {
                return BadRequest((new Error(0, exError.Message, "GetItem").ToString()));
            }
        }


        // GET: api/TransferActivity
        [HttpGet]
        [ActionName("Items")]
        [SwaggerOperation("Items")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]

        public IHttpActionResult Items()
        {
            try
            {
                TransferActivityRepository ta = new TransferActivityRepository(db);
                return Ok(ta.Items());
            }
            catch (Exception exError)
            {
                return BadRequest((new Error(0, exError.Message, "GetItems").ToString()));
            }
        }


        // PUT: api/TransferActivity/5
        [HttpPut]
        [SwaggerOperation("Update Item")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [ResponseType(typeof(void))]
        public IHttpActionResult Item(int id, TransferActivityDTO transfer_activity)
        {
            try
            {
                TransferActivityRepository ta = new TransferActivityRepository(db);
                ta.Update(transfer_activity);

                return Ok();
            }
            catch (Exception exError)
            {
                return BadRequest((new Error(0, exError.Message, "Update Item").ToString()));
            }
        }

        // POST: api/TransferActivity
        [HttpPost]
        [SwaggerOperation("Create Item")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IHttpActionResult Item(TransferActivityDTO transfer_activity)
        {
            try
            {
                TransferActivityRepository ta = new TransferActivityRepository(db);
                return Ok(ta.Create(transfer_activity));
            }
            catch (Exception exError)
            {
                return BadRequest((new Error(0, exError.Message, "Create Item").ToString()));
            }
        }

        // POST: api/TransferActivity
        [HttpPost]
        [ActionName("BatchSave")]
        [SwaggerOperation("BatchSave")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IHttpActionResult BatchSave(TransferActivityBatchDTO[] transferactivities)
        {
            TransferActivityRepository ta = new TransferActivityRepository(db);

            foreach (TransferActivityBatchDTO taItem in transferactivities)
            {
                switch (taItem.action.ToUpper())
                {
                    case "CREATE":
                        ta.Create(taItem.transfer_activity);
                        break;
                    case "UPDATE":
                        ta.Update(taItem.transfer_activity);
                        break;
                    case "DELETE":
                        ta.Delete(taItem.transfer_activity.transfer_activity_key);
                        break;
                }
            }

            return Ok();
        }

        // DELETE: api/TransferActivity/5
        [HttpDelete]
        [ActionName("Item")]
        [SwaggerOperation("Item")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IHttpActionResult Item(int transfer_activity_key)
        {
            try
            {
                TransferActivityRepository ta = new TransferActivityRepository(db);
                ta.Delete(transfer_activity_key);
                return Ok();
            }
            catch (Exception exError)
            {
                return BadRequest((new Error(0, exError.Message, "Delete Item").ToString()));
            }
        }

        private bool transfer_activityExists(int id)
        {
            return db.transfer_activity.Count(e => e.transfer_activity_key == id) > 0;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}