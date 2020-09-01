using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3IllusionaryObstacle : CGameplayEntity
	{
		[Ordinal(0)] [RED("("focusAreaIntensity")] 		public CFloat FocusAreaIntensity { get; set;}

		[Ordinal(0)] [RED("("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(0)] [RED("("m_disappearanceEffectDuration")] 		public CFloat M_disappearanceEffectDuration { get; set;}

		[Ordinal(0)] [RED("("m_addFactOnDispel")] 		public CString M_addFactOnDispel { get; set;}

		[Ordinal(0)] [RED("("m_addFactOnDiscovery")] 		public CString M_addFactOnDiscovery { get; set;}

		[Ordinal(0)] [RED("("discoveryOnelinerTag")] 		public CString DiscoveryOnelinerTag { get; set;}

		[Ordinal(0)] [RED("("m_discoveryOneliner")] 		public CEnum<EIllusionDiscoveredOneliner> M_discoveryOneliner { get; set;}

		[Ordinal(0)] [RED("("m_illusionDiscoveredEver")] 		public CBool M_illusionDiscoveredEver { get; set;}

		[Ordinal(0)] [RED("("m_illusionDiscoveredThisSession")] 		public CBool M_illusionDiscoveredThisSession { get; set;}

		[Ordinal(0)] [RED("("interactionComponent")] 		public CHandle<CInteractionComponent> InteractionComponent { get; set;}

		[Ordinal(0)] [RED("("meshComponent")] 		public CHandle<CMeshComponent> MeshComponent { get; set;}

		[Ordinal(0)] [RED("("m_effectRange")] 		public CFloat M_effectRange { get; set;}

		[Ordinal(0)] [RED("("m_wasDestroyed")] 		public CBool M_wasDestroyed { get; set;}

		[Ordinal(0)] [RED("("m_illusionSpawner")] 		public CHandle<W3IllusionSpawner> M_illusionSpawner { get; set;}

		[Ordinal(0)] [RED("("isFocusAreaActive")] 		public CBool IsFocusAreaActive { get; set;}

		[Ordinal(0)] [RED("("focusModeHighlight")] 		public CEnum<EFocusModeVisibility> FocusModeHighlight { get; set;}

		[Ordinal(0)] [RED("("i")] 		public CInt32 I { get; set;}

		[Ordinal(0)] [RED("("l_entitiesAround", 2,0)] 		public CArray<CHandle<CGameplayEntity>> L_entitiesAround { get; set;}

		[Ordinal(0)] [RED("("l_illusion")] 		public CHandle<W3IllusionaryObstacle> L_illusion { get; set;}

		[Ordinal(0)] [RED("("saveLockID")] 		public CInt32 SaveLockID { get; set;}

		public W3IllusionaryObstacle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3IllusionaryObstacle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}