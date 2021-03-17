using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStepperData : CVariable
	{
		private CString _label;
		private wCHandle<IScriptable> _data;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public wCHandle<IScriptable> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public inkStepperData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
