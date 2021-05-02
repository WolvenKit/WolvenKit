using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimInputSetterVector : entAnimInputSetter
	{
		private Vector4 _value;

		[Ordinal(1)] 
		[RED("value")] 
		public Vector4 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public entAnimInputSetterVector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
