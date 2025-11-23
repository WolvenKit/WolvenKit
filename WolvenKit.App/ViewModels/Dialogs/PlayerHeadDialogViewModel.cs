using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class PlayerHeadDialogViewModel : DialogViewModel
{
    [ObservableProperty] private PhotomodeBodyGender _bodyGender;
    public readonly List<string> SelectedFiles = [];

    public PlayerHeadDialogViewModel() => SetBodyGender(PhotomodeBodyGender.Female);

    public void SetBodyGender(PhotomodeBodyGender gender)
    {
        BodyGender = gender;
        switch (gender)
        {
            case PhotomodeBodyGender.Female:
                SelectedFiles.Clear();
                SelectedFiles.AddRange(s_femFiles);
                break;
            case PhotomodeBodyGender.Male:
                SelectedFiles.Clear();
                SelectedFiles.AddRange(s_mascFiles);
                break;
            default:
                break;
        }
    }

    private static readonly List<string> s_femFiles =
    [
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_cyberware_07.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\h0_000_pwa_c__basehead_proxy.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\h0_000_pwa_c__basehead.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\he_000_pwa_c__basehead.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\heb_000_pwa_c__basehead.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\ht_000_pwa_c__basehead.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_cyberware_01.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_cyberware_02.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_cyberware_03.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_cyberware_04.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_cyberware_05.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_cyberware_06.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_makeup_eyes_01.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_makeup_freckles_01.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_makeup_lips_01.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_personal_slot_dec.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_pimples_01.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_scars_01.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_scars_02.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_tattoo_01.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_tattoo_02.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_tattoo_03.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_tattoo_04.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_tattoo_05.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_tattoo_06.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_tattoo_07.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_tattoo_08.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_tattoo_09.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_tattoo_10.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\hx_000_pwa_c__basehead_tattoo_npc_01.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\i1_000_pwa_c__basehead_earring_01.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\i1_000_pwa_c__basehead_earring_02.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\i1_000_pwa_c__basehead_earring_03.mesh",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa_c__basehead\i1_000_pwa_c__basehead_earring_04.mesh",

        @"base\characters\head\player_base_heads\player_female_average\heb_000_pwa__morphs.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\h0_000_pwa__morphs.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\he_000_pwa__morphs.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\ht_000_pwa__morphs.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_cyberware_01.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_cyberware_02.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_cyberware_03.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_cyberware_04.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_cyberware_05.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_cyberware_06.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_cyberware_07.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_makeup_eyes_01.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_makeup_freckles_01.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_makeup_lips_01.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_personal_slot_dec.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_pimples_01.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_scars_01.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_scars_02.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_tattoo_01.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_tattoo_02.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_tattoo_03.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_tattoo_04.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_tattoo_05.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_tattoo_06.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_tattoo_07.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_tattoo_08.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_tattoo_09.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\hx_000_pwa__morphs_tattoo_10.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\i1_000_pwa__morphs_earring_01.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\i1_000_pwa__morphs_earring_02.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\i1_000_pwa__morphs_earring_03.morphtarget",
        @"base\characters\head\player_base_heads\player_female_average\i1_000_pwa__morphs_earring_04.morphtarget",
    ];

    private static readonly List<string> s_mascFiles =
    [
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_big_beard.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma__morphs.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_big_beard_afro.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_default.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_fu_manchu.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_handlebar_stache.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_jesse_beard.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_logan.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_maelstrom_full.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_maelstrom_goatie.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_patmc.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_shadowbase_01.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_short_afro.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hb_000_pma__morphs_thick_beard_afro.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\he_000_pma__morphs.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\heb_000_pma__morphs.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\ht_000_pma__morphs.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_cyberware_01.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_cyberware_02.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_cyberware_03.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_cyberware_04.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_cyberware_05.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_cyberware_06.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_cyberware_07.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_makeup_eyes_01.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_makeup_freckles_01.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_makeup_lips_01.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_personal_slot_dec.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_pimples_01.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_scars_01.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_scars_02.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_tattoo_01.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_tattoo_02.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_tattoo_03.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_tattoo_04.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_tattoo_05.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_tattoo_06.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_tattoo_07.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_tattoo_08.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_tattoo_09.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\hx_000_pma__morphs_tattoo_10.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\i1_000_pma__morphs_earring_01.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\i1_000_pma__morphs_earring_02.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\i1_000_pma__morphs_earring_03.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\i1_000_pma__morphs_earring_04.morphtarget",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead_maelstrom_goatie.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\h0_000_pma_c__basehead_proxy.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\h0_000_pma_c__basehead_scars.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\h0_000_pma_c__basehead.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead_big_beard_afro.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead_big_beard.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead_fu_manchu.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead_handlebar_stache.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead_jesse_beard.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead_logan.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead_maelstrom_full.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead_patmc.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead_shadowbase_01.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead_short_afro.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead_thick_beard_afro.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hb_000_pma_c__basehead.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\he_000_pma_c__basehead.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\heb_000_pma_c__basehead.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\ht_000_pma_c__basehead.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_cyberware_01.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_cyberware_02.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_cyberware_03.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_cyberware_04.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_cyberware_05.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_cyberware_06.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_cyberware_07.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_makeup_eyes_01.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_makeup_freckles_01.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_makeup_lips_01.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_personal_slot_dec.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_pimples_01.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_scars_01.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_scars_02.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_tattoo_01.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_tattoo_02.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_tattoo_03.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_tattoo_04.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_tattoo_05.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_tattoo_06.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_tattoo_07.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_tattoo_08.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_tattoo_09.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_tattoo_10.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\hx_000_pma_c__basehead_tattoo_npc_01.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\i1_000_pma_c__basehead_earring_01.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\i1_000_pma_c__basehead_earring_02.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\i1_000_pma_c__basehead_earring_03.mesh",
        @"base\characters\head\player_base_heads\player_man_average\h0_000_pma_c__basehead\i1_000_pma_c__basehead_earring_04.mesh",
    ];
}
