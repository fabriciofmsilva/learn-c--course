using SimpleWebScraper.Data;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SimpleWebScraper.Builders
{
    class ScrapeCriteiaBuilder
    {
        private string _data;
        private string _regex;
        private RegexOptions _regexOptions;
        private List<ScrapeCriteriaPart> _parts;

        public ScrapeCriteiaBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _data = string.Empty;
            _regex = string.Empty;
            _regexOptions = RegexOptions.None;
            _parts = new List<ScrapeCriteriaPart>();
        }

        public ScrapeCriteiaBuilder WithData(string data)
        {
            _data = data;
            return this;
        }

        public ScrapeCriteiaBuilder WithRegex(string regex)
        {
            _regex = regex;
            return this;
        }

        public ScrapeCriteiaBuilder WithRegexOptions(RegexOptions regexOptions)
        {
            _regexOptions = regexOptions;
            return this;
        }

        public ScrapeCriteiaBuilder WithPart(ScrapeCriteriaPart scrapeCriteriaPart)
        {
            _parts.Add(scrapeCriteriaPart);
            return this;
        }

        public ScrapeCriteria Build()
        {
            ScrapeCriteria scrapeCriteria = new ScrapeCriteria();
            scrapeCriteria.Data = _data;
            scrapeCriteria.Regex = _regex;
            scrapeCriteria.RegexOption = _regexOptions;
            scrapeCriteria.Parts = _parts;
            return scrapeCriteria;
        }
    }
}
