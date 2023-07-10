using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcontrato.Controller
{
    public class GeolocalizacaoController
    {
        public static Model.Geolocalizacao ObtemGeolocalizacaoAtual()
        {

            Model.Geolocalizacao geolocalizacao = new Model.Geolocalizacao();

            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
            watcher.Start(); //started watcher
            GeoCoordinate coord = watcher.Position.Location;
            if (!watcher.Position.Location.IsUnknown)
            {
                geolocalizacao.Latitude = coord.Latitude; //latitude
                geolocalizacao.Longitude = coord.Longitude;  //logitude
            }

            return geolocalizacao;

        }
    }
}
