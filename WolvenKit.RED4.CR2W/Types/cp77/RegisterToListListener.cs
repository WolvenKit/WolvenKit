using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterToListListener : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _object;
		private CName _funcName;

		[Ordinal(0)] 
		[RED("object")] 
		public wCHandle<gameObject> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}

		[Ordinal(1)] 
		[RED("funcName")] 
		public CName FuncName
		{
			get => GetProperty(ref _funcName);
			set => SetProperty(ref _funcName, value);
		}

		public RegisterToListListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
