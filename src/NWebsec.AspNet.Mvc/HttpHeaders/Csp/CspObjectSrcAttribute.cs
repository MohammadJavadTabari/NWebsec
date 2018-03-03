// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.Mvc.Common.Helpers;
using NWebsec.Mvc.HttpHeaders.Csp.Internals;

namespace NWebsec.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the object-src directive for the CSP header (CSP 1.0). 
    /// </summary>
    public class CspObjectSrcAttribute : CspDirectiveAttributeBase
    {
        protected override CspDirectives Directive
        {
            get { return CspDirectives.ObjectSrc; }
        }

        protected override bool ReportOnly
        {
            get { return false; }
        }
    }
}