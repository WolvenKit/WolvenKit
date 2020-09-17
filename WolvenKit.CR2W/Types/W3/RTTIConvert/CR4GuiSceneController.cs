using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GuiSceneController : CObject
	{
		[Ordinal(1)] [RED("_isEntitySpawning")] 		public CBool _isEntitySpawning { get; set;}

		[Ordinal(2)] [RED("_entityTemplateAlias")] 		public CString _entityTemplateAlias { get; set;}

		[Ordinal(3)] [RED("_entityAppearance")] 		public CName _entityAppearance { get; set;}

		[Ordinal(4)] [RED("_environmentAlias")] 		public CString _environmentAlias { get; set;}

		[Ordinal(5)] [RED("_environmentSunRotation")] 		public EulerAngles _environmentSunRotation { get; set;}

		[Ordinal(6)] [RED("_cameraUpdate")] 		public CBool _cameraUpdate { get; set;}

		[Ordinal(7)] [RED("_cameraLookAt")] 		public Vector _cameraLookAt { get; set;}

		[Ordinal(8)] [RED("_cameraRotation")] 		public EulerAngles _cameraRotation { get; set;}

		[Ordinal(9)] [RED("_cameraDistance")] 		public CFloat _cameraDistance { get; set;}

		[Ordinal(10)] [RED("_fov")] 		public CFloat _fov { get; set;}

		[Ordinal(11)] [RED("_updateItems")] 		public CBool _updateItems { get; set;}

		[Ordinal(12)] [RED("_cachedDyes", 2,0)] 		public CArray<CName> _cachedDyes { get; set;}

		[Ordinal(13)] [RED("_appliedDyesPreview", 2,0)] 		public CArray<CName> _appliedDyesPreview { get; set;}

		[Ordinal(14)] [RED("_entityPosition")] 		public Vector _entityPosition { get; set;}

		[Ordinal(15)] [RED("_entityRotation")] 		public EulerAngles _entityRotation { get; set;}

		[Ordinal(16)] [RED("_entityScale")] 		public Vector _entityScale { get; set;}

		[Ordinal(17)] [RED("_updateEntityTransform")] 		public CBool _updateEntityTransform { get; set;}

		[Ordinal(18)] [RED("m_charRenderFocus")] 		public CEnum<EGuiSceneControllerRenderFocus> M_charRenderFocus { get; set;}

		[Ordinal(19)] [RED("m_charFocusOriginZ")] 		public CFloat M_charFocusOriginZ { get; set;}

		[Ordinal(20)] [RED("m_charFocusOriginDistance")] 		public CFloat M_charFocusOriginDistance { get; set;}

		[Ordinal(21)] [RED("m_charFocusTargetZ")] 		public CFloat M_charFocusTargetZ { get; set;}

		[Ordinal(22)] [RED("m_charFocusTargetDistance")] 		public CFloat M_charFocusTargetDistance { get; set;}

		[Ordinal(23)] [RED("m_charFocusBlendTimer")] 		public CFloat M_charFocusBlendTimer { get; set;}

		[Ordinal(24)] [RED("m_charFocusBlendTime")] 		public CFloat M_charFocusBlendTime { get; set;}

		[Ordinal(25)] [RED("m_distanceMin")] 		public CFloat M_distanceMin { get; set;}

		[Ordinal(26)] [RED("m_distanceMax")] 		public CFloat M_distanceMax { get; set;}

		[Ordinal(27)] [RED("m_zMin")] 		public CFloat M_zMin { get; set;}

		[Ordinal(28)] [RED("m_zMax")] 		public CFloat M_zMax { get; set;}

		[Ordinal(29)] [RED("m_zBody")] 		public CFloat M_zBody { get; set;}

		public CR4GuiSceneController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4GuiSceneController(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}