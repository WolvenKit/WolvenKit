using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopGraphConnectionCreationData : CVariable
	{
		private CString _data;
		private CArray<CString> _extraData;

		[Ordinal(0)] 
		[RED("data")] 
		public CString Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("extraData")] 
		public CArray<CString> ExtraData
		{
			get => GetProperty(ref _extraData);
			set => SetProperty(ref _extraData, value);
		}

		public interopGraphConnectionCreationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
