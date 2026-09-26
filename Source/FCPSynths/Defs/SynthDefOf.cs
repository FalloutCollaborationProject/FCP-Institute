namespace FCP.Synths;

[DefOf]
public static class SynthDefOf
{
    public static HediffDef FCP_Hediff_SynthComponents_GenIII;
    public static XenotypeDef FCP_Xenotype_Synth_GenI;
    public static XenotypeDef FCP_Xenotype_Synth_GenII;
    public static FactionDef FCP_Faction_Institute;
    public static LetterDef FCP_Letter_InstituteRelocationOffer;
    public static PawnKindDef FCP_Pawnkind_Institute_RequisitionOfficer;
    public static TraderKindDef FCP_TraderKind_Institute_Requisition;
    public static FCP.Enlist.FactionEnlistOptionsDef FCP_Enlistment_Institute;

    static SynthDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(SynthDefOf));
    }
}
