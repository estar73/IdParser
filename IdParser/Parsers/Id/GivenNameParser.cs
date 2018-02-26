﻿using IdParser.Attributes;

namespace IdParser.Parsers.Id
{
    [Parser("DCT")]
    public class GivenNameParser : AbstractParser
    {
        // AAMVA 2003-2005
        public GivenNameParser(IdParser.IdentificationCard idCard, Version version, Country country) : base(idCard, version, country)
        {
        }

        public override void ParseAndSet(string input)
        {
            var givenNames = input.Split(',', '$', ' ');
            IdCard.FirstName = givenNames[0].Trim();
            IdCard.MiddleName = givenNames.Length > 1 ? givenNames[1].Trim().ReplaceEmptyWithNull() : null;
        }
    }
}