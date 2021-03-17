using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCallbackListener : CVariable
	{
		private wCHandle<IScriptable> _object;
		private CName _functionName;

		[Ordinal(0)] 
		[RED("object")] 
		public wCHandle<IScriptable> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}

		[Ordinal(1)] 
		[RED("functionName")] 
		public CName FunctionName
		{
			get => GetProperty(ref _functionName);
			set => SetProperty(ref _functionName, value);
		}

		public inkCallbackListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
