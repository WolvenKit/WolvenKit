using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseMenuGameControllerPuppetSceneInfo : CVariable
	{
		private CName _sceneName;
		private NodeRef _markerRef;
		private NodeRef _prefabRef;
		private raRef<entEntityTemplate> _entityTemplate;
		private TweakDBID _puppetRecordId;
		private CEnum<gameuiBaseMenuGameControllerPuppetGenderInfo> _gender;

		[Ordinal(0)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get => GetProperty(ref _sceneName);
			set => SetProperty(ref _sceneName, value);
		}

		[Ordinal(1)] 
		[RED("markerRef")] 
		public NodeRef MarkerRef
		{
			get => GetProperty(ref _markerRef);
			set => SetProperty(ref _markerRef, value);
		}

		[Ordinal(2)] 
		[RED("prefabRef")] 
		public NodeRef PrefabRef
		{
			get => GetProperty(ref _prefabRef);
			set => SetProperty(ref _prefabRef, value);
		}

		[Ordinal(3)] 
		[RED("entityTemplate")] 
		public raRef<entEntityTemplate> EntityTemplate
		{
			get => GetProperty(ref _entityTemplate);
			set => SetProperty(ref _entityTemplate, value);
		}

		[Ordinal(4)] 
		[RED("puppetRecordId")] 
		public TweakDBID PuppetRecordId
		{
			get => GetProperty(ref _puppetRecordId);
			set => SetProperty(ref _puppetRecordId, value);
		}

		[Ordinal(5)] 
		[RED("gender")] 
		public CEnum<gameuiBaseMenuGameControllerPuppetGenderInfo> Gender
		{
			get => GetProperty(ref _gender);
			set => SetProperty(ref _gender, value);
		}

		public gameuiBaseMenuGameControllerPuppetSceneInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
