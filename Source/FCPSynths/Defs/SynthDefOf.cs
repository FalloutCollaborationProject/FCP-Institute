namespace FCP.Synths;

[DefOf]
public static class SynthDefOf
{
    public static HediffDef FCP_Hediff_SynthComponents_GenIII;
    public static XenotypeDef FCP_Xenotype_Synth_GenI;
    public static XenotypeDef FCP_Xenotype_Synth_GenII;
    public static FactionDef FCP_Faction_Institute;
    public static LetterDef FCP_Letter_InstituteRelocationOffer;

    static SynthDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(SynthDefOf));
    }
}
