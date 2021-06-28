using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerAuthorization : ScannerChunk
	{
		private CBool _keycard;
		private CBool _password;

		[Ordinal(0)] 
		[RED("keycard")] 
		public CBool Keycard
		{
			get => GetProperty(ref _keycard);
			set => SetProperty(ref _keycard, value);
		}

		[Ordinal(1)] 
		[RED("password")] 
		public CBool Password
		{
			get => GetProperty(ref _password);
			set => SetProperty(ref _password, value);
		}

		public ScannerAuthorization(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
