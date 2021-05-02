using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeStruct : CVariable
	{
		private CName _key;
		private raRef<entEntityTemplate> _entityTemplate;

		[Ordinal(0)] 
		[RED("key")] 
		public CName Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(1)] 
		[RED("entityTemplate")] 
		public raRef<entEntityTemplate> EntityTemplate
		{
			get => GetProperty(ref _entityTemplate);
			set => SetProperty(ref _entityTemplate, value);
		}

		public gameNetrunnerPrototypeStruct(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
