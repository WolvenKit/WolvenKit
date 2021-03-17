using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceComputerUIData : CVariable
	{
		private CArray<gamedeviceGenericDataContent> _mails;
		private CArray<gamedeviceGenericDataContent> _files;

		[Ordinal(0)] 
		[RED("mails")] 
		public CArray<gamedeviceGenericDataContent> Mails
		{
			get => GetProperty(ref _mails);
			set => SetProperty(ref _mails, value);
		}

		[Ordinal(1)] 
		[RED("files")] 
		public CArray<gamedeviceGenericDataContent> Files
		{
			get => GetProperty(ref _files);
			set => SetProperty(ref _files, value);
		}

		public gamedeviceComputerUIData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
