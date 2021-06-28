using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceGenericDataContent : CVariable
	{
		private CString _name;
		private CArray<gamedeviceDataElement> _content;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("content")] 
		public CArray<gamedeviceDataElement> Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}

		public gamedeviceGenericDataContent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
