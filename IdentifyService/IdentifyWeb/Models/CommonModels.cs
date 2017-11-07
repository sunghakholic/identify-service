﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentifyWeb.Models
{ 
    public class JsonUrlBlob
    {
        public string url { get; set; }

        public JsonUrlBlob(string urlstring)
        {
            url = urlstring;
        }
    }


    public class JsonFaceId
    {
        public string faceId { get; set; }

        public JsonFaceId(string faceIdString)
        {
            faceId = faceIdString;
        }
    }


    public class FaceDetectResult
    {
        public string faceId { get; set; }
        public object faceRectangle { get; set; }
        public object faceLandmarks { get; set; }
        public object faceAttributes { get; set; }
    }





    public class CreatePersonResult
    {
        public string personId { get; set; }
        public CreatePersonResult(string personIdString)
        {
            personId = personIdString;
        }
    }

    public class PersonGroupTrainingStatus
    {
        public string status { get; set; }
        public string createDataTime { get; set; }
        public string lastActionDateTime { get; set; }
        public string message { get; set; }

    }
}