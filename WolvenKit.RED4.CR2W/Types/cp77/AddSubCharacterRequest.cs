using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddSubCharacterRequest : gameScriptableSystemRequest
	{
		private wCHandle<ScriptedPuppet> _subCharObject;

		[Ordinal(0)] 
		[RED("subCharObject")] 
		public wCHandle<ScriptedPuppet> SubCharObject
		{
			get => GetProperty(ref _subCharObject);
			set => SetProperty(ref _subCharObject, value);
		}

		public AddSubCharacterRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
