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
		[RED("focusAreaIntensity")] 		public CFloat FocusAreaIntensity { get; set;}

		[RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[RED("m_disappearanceEffectDuration")] 		public CFloat M_disappearanceEffectDuration { get; set;}

		[RED("m_addFactOnDispel")] 		public CString M_addFactOnDispel { get; set;}

		[RED("m_addFactOnDiscovery")] 		public CString M_addFactOnDiscovery { get; set;}

		[RED("discoveryOnelinerTag")] 		public CString DiscoveryOnelinerTag { get; set;}

		[RED("m_discoveryOneliner")] 		public CEnum<EIllusionDiscoveredOneliner> M_discoveryOneliner { get; set;}

		[RED("m_illusionDiscoveredEver")] 		public CBool M_illusionDiscoveredEver { get; set;}

		[RED("m_illusionDiscoveredThisSession")] 		public CBool M_illusionDiscoveredThisSession { get; set;}

		[RED("interactionComponent")] 		public CHandle<CInteractionComponent> InteractionComponent { get; set;}

		[RED("meshComponent")] 		public CHandle<CMeshComponent> MeshComponent { get; set;}

		[RED("m_effectRange")] 		public CFloat M_effectRange { get; set;}

		[RED("m_wasDestroyed")] 		public CBool M_wasDestroyed { get; set;}

		[RED("m_illusionSpawner")] 		public CHandle<W3IllusionSpawner> M_illusionSpawner { get; set;}

		[RED("isFocusAreaActive")] 		public CBool IsFocusAreaActive { get; set;}

		[RED("focusModeHighlight")] 		public CEnum<EFocusModeVisibility> FocusModeHighlight { get; set;}

		[RED("i")] 		public CInt32 I { get; set;}

		[RED("l_entitiesAround", 2,0)] 		public CArray<CHandle<CGameplayEntity>> L_entitiesAround { get; set;}

		[RED("l_illusion")] 		public CHandle<W3IllusionaryObstacle> L_illusion { get; set;}

		[RED("saveLockID")] 		public CInt32 SaveLockID { get; set;}

		public W3IllusionaryObstacle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3IllusionaryObstacle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}