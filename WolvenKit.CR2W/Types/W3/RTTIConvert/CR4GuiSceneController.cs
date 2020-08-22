using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GuiSceneController : CObject
	{
		[RED("_isEntitySpawning")] 		public CBool _isEntitySpawning { get; set;}

		[RED("_entityTemplateAlias")] 		public CString _entityTemplateAlias { get; set;}

		[RED("_entityAppearance")] 		public CName _entityAppearance { get; set;}

		[RED("_environmentAlias")] 		public CString _environmentAlias { get; set;}

		[RED("_environmentSunRotation")] 		public EulerAngles _environmentSunRotation { get; set;}

		[RED("_cameraUpdate")] 		public CBool _cameraUpdate { get; set;}

		[RED("_cameraLookAt")] 		public Vector _cameraLookAt { get; set;}

		[RED("_cameraRotation")] 		public EulerAngles _cameraRotation { get; set;}

		[RED("_cameraDistance")] 		public CFloat _cameraDistance { get; set;}

		[RED("_fov")] 		public CFloat _fov { get; set;}

		[RED("_updateItems")] 		public CBool _updateItems { get; set;}

		[RED("_cachedDyes", 2,0)] 		public CArray<CName> _cachedDyes { get; set;}

		[RED("_appliedDyesPreview", 2,0)] 		public CArray<CName> _appliedDyesPreview { get; set;}

		[RED("_entityPosition")] 		public Vector _entityPosition { get; set;}

		[RED("_entityRotation")] 		public EulerAngles _entityRotation { get; set;}

		[RED("_entityScale")] 		public Vector _entityScale { get; set;}

		[RED("_updateEntityTransform")] 		public CBool _updateEntityTransform { get; set;}

		[RED("m_charRenderFocus")] 		public CEnum<EGuiSceneControllerRenderFocus> M_charRenderFocus { get; set;}

		[RED("m_charFocusOriginZ")] 		public CFloat M_charFocusOriginZ { get; set;}

		[RED("m_charFocusOriginDistance")] 		public CFloat M_charFocusOriginDistance { get; set;}

		[RED("m_charFocusTargetZ")] 		public CFloat M_charFocusTargetZ { get; set;}

		[RED("m_charFocusTargetDistance")] 		public CFloat M_charFocusTargetDistance { get; set;}

		[RED("m_charFocusBlendTimer")] 		public CFloat M_charFocusBlendTimer { get; set;}

		[RED("m_charFocusBlendTime")] 		public CFloat M_charFocusBlendTime { get; set;}

		[RED("m_distanceMin")] 		public CFloat M_distanceMin { get; set;}

		[RED("m_distanceMax")] 		public CFloat M_distanceMax { get; set;}

		[RED("m_zMin")] 		public CFloat M_zMin { get; set;}

		[RED("m_zMax")] 		public CFloat M_zMax { get; set;}

		[RED("m_zBody")] 		public CFloat M_zBody { get; set;}

		public CR4GuiSceneController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4GuiSceneController(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}