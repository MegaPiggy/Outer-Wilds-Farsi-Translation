﻿using OWML.Common;
using OWML.ModHelper;

namespace FarsiTranslation
{
    public class FarsiTranslation : ModBehaviour
    {
        private void Start()
        {
            ModHelper.Console.WriteLine($"{nameof(FarsiTranslation)} is loaded!", MessageType.Success);

            ModHelper.Interaction.TryGetModApi<ILocalizationAPI>("xen.LocalizationUtility").RegisterLanguage(this, "Arabic", "assets/Translations.xml", "assets/b_mitra_0", "Assets/B_MITRA_0.TTF", ArabicSupport.ArabicFixer.Fix);
        }
    }
}
