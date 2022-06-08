using System;

namespace StudentPortal.API.DomainModels
{
    public class AddressDM
    {
        public Guid Id { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }

        public Guid StudentId { get; set; }
    }
}
