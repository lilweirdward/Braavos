﻿namespace Braavos.Entities
{
    public class AuthRequest
    {
        public int NationId { get; set; }
        public string RulerName { get; set; }
        public string UniqueCode { get; set; }

        public AuthRequest() { }

        public AuthRequest(int nationId, string uniqueCode) => (NationId, UniqueCode) = (nationId, uniqueCode);

        public AuthRequest(string rulerName, string uniqueCode) => (RulerName, UniqueCode) = (rulerName, uniqueCode);
    }
}
