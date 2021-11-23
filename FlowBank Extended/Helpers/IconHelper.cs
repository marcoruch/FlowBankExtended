using FlowBank_Extended.API.Endpoints;

using Svg;

using System;
using System.Drawing;
using System.Net;

namespace FlowBank_Extended.Helpers
{
    public static class IconHelper
    {
        public static Bitmap GetBitmapFromSymbolId(string symbolId)
        {
            var rawr = new SymbolsEndpoint().GetById(symbolId).Result;

            return GetBitmapFromSvgUrl(rawr.Data.Icon);
        }

        public static Bitmap GetBitmapFromPngUrl(string pngUrl)
        {
            using (var response = WebRequest.Create(pngUrl).GetResponse())
            using (var stream = response.GetResponseStream())
                return (Bitmap)Image.FromStream(stream);
        }

        public static Bitmap GetBitmapFromSvgUrl(string svgUrl)
        {
            try
            {

                using (var response = WebRequest.Create(svgUrl).GetResponse())
                using (var stream = response.GetResponseStream())
                    return SvgDocument.Open<SvgDocument>(stream).Draw();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
