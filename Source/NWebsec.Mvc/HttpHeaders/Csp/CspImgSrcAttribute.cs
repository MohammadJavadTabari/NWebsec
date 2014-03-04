// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.Helpers;
using NWebsec.HttpHeaders;
using NWebsec.Mvc.HttpHeaders.Csp.Internals;

namespace NWebsec.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the img-src directive for the CSP header. 
    /// </summary>
    public class CspImgSrcAttribute : CspDirectiveAttributeBase
    {
        protected override HttpHeaderConfigurationOverrideHelper.CspDirectives Directive
        {
            get { return HttpHeaderConfigurationOverrideHelper.CspDirectives.ImgSrc; }
        }

        protected override bool ReportOnly
        {
            get { return false; }
        }
    }
}