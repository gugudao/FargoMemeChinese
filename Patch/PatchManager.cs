﻿using FargoMemeChinese.Patch.Fargowiltas;
using FargoMemeChinese.Patch.FargowiltasSouls;
using Terraria.ModLoader;

namespace FargoMemeChinese.Patch
{
    public class PatchManager : ModSystem
    {
        public override void Load()
        {
            ChatButtonsTranslate.Load();
            ChatMessagesTranslate.Load();
            KeyBindsTranslate.Load();
            StatSheetTranslate.Load();

            if (ModLoader.TryGetMod("FargowiltasSouls", out _))
            {
                BossChecklistTranslate.Load();
                DropConditionsTranslate.Load();
                NurseCantHealTranslate.Load();
                UITranslate.Load();
            }
        }
        public override void Unload()
        {
            ChatButtonsTranslate.Unload();
            ChatMessagesTranslate.Load();
            KeyBindsTranslate.Unload();
            StatSheetTranslate.Unload();

            if (ModLoader.TryGetMod("FargowiltasSouls", out _))
            {
                DropConditionsTranslate.Unload();
                NurseCantHealTranslate.Unload();
                UITranslate.Unload();
            }
        }
    }
}