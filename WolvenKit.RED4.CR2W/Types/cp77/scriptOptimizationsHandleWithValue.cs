using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scriptOptimizationsHandleWithValue : CVariable
	{
		private CFloat _value;
		private CHandle<IScriptable> _handle;

		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("handle")] 
		public CHandle<IScriptable> Handle
		{
			get => GetProperty(ref _handle);
			set => SetProperty(ref _handle, value);
		}

		public scriptOptimizationsHandleWithValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
