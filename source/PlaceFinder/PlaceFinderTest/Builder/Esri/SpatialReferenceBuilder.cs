using ESRI.ArcGIS.Geometry;
using Rhino.Mocks;

namespace GeodataStyrelsen.ArcMap.PlaceFinderTest.Builder.Esri
{
    public class SpatialReferenceBuilder : BaseBuilder<ISpatialReference>
    {
        private int _code;

        public SpatialReferenceBuilder()
        {
            Build.Stub(m => m.FactoryCode).Return(4326);
        }

        public SpatialReferenceBuilder(int code)
        {
            _code = code;
            Build.Stub(m => m.FactoryCode).Return(_code);
        }
    }
}