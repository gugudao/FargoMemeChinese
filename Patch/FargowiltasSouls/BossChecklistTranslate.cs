﻿using FargowiltasSouls.Items.Summons;
using Terraria.Localization;
using Terraria.ModLoader;

namespace FargoMemeChinese.Patch.FargowiltasSouls
{
    [JITWhenModsEnabled("FargowiltasSouls")]
    public static class BossChecklistTranslate
    {
        public static void Load()
        {
            if (ModLoader.TryGetMod("FargowiltasSouls", out Mod fargoSouls))
            {
                ModTranslation translation = LocalizationLoader.GetOrCreateTranslation(fargoSouls, "BossChecklist.LifeChallengerSpawnInfo");
                translation.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), $"白天时在神圣之地使用[i:{ModContent.ItemType<FragilePixieLamp>()}]召唤。");
            }
        }
    }
}
