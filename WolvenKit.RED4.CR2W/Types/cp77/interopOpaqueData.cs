using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopOpaqueData : CVariable
	{
		private CString _description;
		private CString _payload;
		private CInt32 _version;

		[Ordinal(0)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(1)] 
		[RED("payload")] 
		public CString Payload
		{
			get => GetProperty(ref _payload);
			set => SetProperty(ref _payload, value);
		}

		[Ordinal(2)] 
		[RED("version")] 
		public CInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		public interopOpaqueData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
