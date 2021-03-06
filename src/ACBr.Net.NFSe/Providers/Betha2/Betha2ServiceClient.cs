// ***********************************************************************
// Assembly         : ACBr.Net.NFSe
// Author           : Rafael Dias
// Created          : 07-30-2017
//
// Last Modified By : Rafael Dias
// Last Modified On : 07-30-2017
// ***********************************************************************
// <copyright file="IBetha2Service.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;
using System.Xml.Linq;
using ACBr.Net.Core.Extensions;
using ACBr.Net.DFe.Core;

namespace ACBr.Net.NFSe.Providers
{
    internal sealed class Betha2ServiceClient : NFSeSOAP11ServiceClient, IABRASF2Client
    {
        #region Constructors

        public Betha2ServiceClient(ProviderBetha2 provider, TipoUrl tipoUrl) : base(provider, tipoUrl, null)
        {
        }

        #endregion Constructors

        #region Methods

        public string CancelarNFSe(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:CancelarNfse>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:CancelarNfse>");

            return Execute("CancelarNfseEnvio", "CancelarNfseResponse", message.ToString());
        }

        public string SubstituirNFSe(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:SubstituirNfse>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:SubstituirNfse>");

            return Execute("SubstituirNfseEnvio", "SubstituirNfseResponse", message.ToString());
        }

        public string ConsultarLoteRps(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:ConsultarLoteRps>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:ConsultarLoteRps>");

            return Execute("ConsultarLoteRpsEnvio", "ConsultarLoteRpsResponse", message.ToString());
        }

        public string ConsultarNFSeFaixa(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:ConsultarNfseFaixa>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:ConsultarNfseFaixa>");

            return Execute("ConsultarNfseFaixaEnvio", "ConsultarNfseFaixaResponse", message.ToString());
        }

        public string ConsultarNFSeServicoTomado(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:ConsultarNfseServicoTomado>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:ConsultarNfseServicoTomado>");

            return Execute("ConsultarNfseServicoTomadoEnvio", "ConsultarNfseServicoTomadoResponse", message.ToString());
        }

        public string ConsultarNFSePorRps(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:ConsultarNfsePorRps>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:ConsultarNfsePorRps>");

            return Execute("ConsultarNfseRpsEnvio", "ConsultarNfsePorRpsResponse", message.ToString());
        }

        public string ConsultarNFSeServicoPrestado(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:ConsultarNfseServicoPrestado>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:ConsultarNfseServicoPrestado>");

            return Execute("ConsultarNfseServicoPrestadoEnvio", "ConsultarNfseServicoPrestadoResponse", message.ToString());
        }

        public string RecepcionarLoteRps(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:RecepcionarLoteRps>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:RecepcionarLoteRps>");

            return Execute("RecepcionarLoteRpsEnvio", "RecepcionarLoteRpsResponse", message.ToString());
        }

        public string RecepcionarLoteRpsSincrono(string cabec, string msg)
        {
            var message = new StringBuilder();
            message.Append("<e:RecepcionarLoteRpsSincrono>");
            message.Append("<nfseCabecMsg>");
            message.AppendCData(cabec);
            message.Append("</nfseCabecMsg>");
            message.Append("<nfseDadosMsg>");
            message.AppendCData(msg);
            message.Append("</nfseDadosMsg>");
            message.Append("</e:RecepcionarLoteRpsSincrono>");

            return Execute("RecepcionarLoteRpsSincronoEnvio", "RecepcionarLoteRpsSincronoResponse", message.ToString());
        }

        private string Execute(string soapAction, string responseTag, string message)
        {
            return Execute(soapAction, message, "", responseTag, "xmlns:e=\"http://www.betha.com.br/e-nota-contribuinte-ws\"");
        }

        protected override string TratarRetorno(XDocument xmlDocument, string[] responseTag)
        {
            var element = xmlDocument.ElementAnyNs("Fault");
            if (element != null)
            {
                var exMessage = $"{element.ElementAnyNs("faultcode").GetValue<string>()} - {element.ElementAnyNs("faultstring").GetValue<string>()}";
                throw new ACBrDFeCommunicationException(exMessage);
            }

            return xmlDocument.ElementAnyNs(responseTag[0]).ElementAnyNs("return").Value;
        }

        #endregion Methods
    }
}