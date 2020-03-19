using System;
using System.Collections.Generic;

namespace Okapi.Web.Api.Console.Test.Models
{
    public class ManagedXPathsDTO
    {
        public Guid Id { get; set; }
        public List<ManagedXPathDTO> Data { get; set; }
    }
}
