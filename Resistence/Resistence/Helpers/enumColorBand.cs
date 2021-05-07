using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistence.Helpers
{
    class enumColorBand
    {
        public enum ColorBand
        {
            [Description("Negro")]
            SelectedOne,
            [Description("Rojo")]
            SelectedTwo,
            [Description("Naranja")]
            SelectedThree,
            [Description("Amarillo")]
            SelectedFour,
            [Description("Verde")]
            SelectedFive,
            [Description("Azul")]
            SelectedSix,
            [Description("Violeta")]
            SelectedSeven,
            [Description("Gris")]
            SelectedEigth,
            [Description("Blanco")]
            SelectedNine 
        }

        public enum ColorMultiplyBand
        {
            [Description("Negro")]
            SelectedOne,
            [Description("Rojo")]
            SelectedTwo,
            [Description("Naranja")]
            SelectedThree,
            [Description("Amarillo")]
            SelectedFour,
            [Description("Verde")]
            SelectedFive,
            [Description("Azul")]
            SelectedSix,
            [Description("Violeta")]
            SelectedSeven,
            [Description("Gris")]
            SelectedEigth,
            [Description("Blanco")]
            SelectedNine
        }
        public enum ColorToleranceBand
        {
            [Description("Rojo")]
            SelectedOne,
            [Description("Oro")]
            SelectedTwo,
            [Description("Plata")]
            SelectedThree
        }
    }
}
