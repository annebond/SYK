using GUI.Commands;
using ServiceLayerLibrary;
using SharedType;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GUI.ViewModel
{
    public class VmCars : BaseViewModel
    {
        public ObservableCollection<Auto> Cars { get; set; }
        private LayerService layerService;

        private MVVMCommand guiRefresh;

        public MVVMCommand GuiRefresh
        {
            get { return guiRefresh; }
            set { guiRefresh = value; }
        }


        public VmCars()
        {
            layerService = new LayerService();
            Cars = new ObservableCollection<Auto>();
            Aktualisieren();
            GuiRefresh = new MVVMCommand((para) => Aktualisieren(), (para) => { return true; });
        }

        public void Aktualisieren()
        {
            foreach (var item in layerService.QueryAll())
            {
                Cars.Add(item);
            }
        }
    }
}
