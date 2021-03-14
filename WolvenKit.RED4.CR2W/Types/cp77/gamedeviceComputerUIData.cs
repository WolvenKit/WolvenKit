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
			get
			{
				if (_mails == null)
				{
					_mails = (CArray<gamedeviceGenericDataContent>) CR2WTypeManager.Create("array:gamedeviceGenericDataContent", "mails", cr2w, this);
				}
				return _mails;
			}
			set
			{
				if (_mails == value)
				{
					return;
				}
				_mails = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("files")] 
		public CArray<gamedeviceGenericDataContent> Files
		{
			get
			{
				if (_files == null)
				{
					_files = (CArray<gamedeviceGenericDataContent>) CR2WTypeManager.Create("array:gamedeviceGenericDataContent", "files", cr2w, this);
				}
				return _files;
			}
			set
			{
				if (_files == value)
				{
					return;
				}
				_files = value;
				PropertySet(this);
			}
		}

		public gamedeviceComputerUIData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
