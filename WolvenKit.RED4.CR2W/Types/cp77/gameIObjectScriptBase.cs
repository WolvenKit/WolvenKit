using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameIObjectScriptBase : IScriptable
	{
		private CHandle<gameObject> _gameObject;

		[Ordinal(0)] 
		[RED("gameObject")] 
		public CHandle<gameObject> GameObject
		{
			get => GetProperty(ref _gameObject);
			set => SetProperty(ref _gameObject, value);
		}

		public gameIObjectScriptBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
