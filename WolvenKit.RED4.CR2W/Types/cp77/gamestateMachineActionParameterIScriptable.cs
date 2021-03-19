using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineActionParameterIScriptable : CVariable
	{
		private CName _name;
		private CHandle<IScriptable> _value;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CHandle<IScriptable> Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public gamestateMachineActionParameterIScriptable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
