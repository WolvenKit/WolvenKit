using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetArgumentVector : SetArguments
	{
		private CHandle<AIArgumentMapping> _newValue;

		[Ordinal(1)] 
		[RED("newValue")] 
		public CHandle<AIArgumentMapping> NewValue
		{
			get => GetProperty(ref _newValue);
			set => SetProperty(ref _newValue, value);
		}

		public SetArgumentVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
