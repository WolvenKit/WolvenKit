using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioLoadingNodeType : questIAudioNodeType
	{
		private CArray<audioSoundBankStruct> _banksToLoad;
		private CArray<audioSoundBankStruct> _banksToUnload;
		private CBool _waitOnLoad;
		private CString _description;

		[Ordinal(0)] 
		[RED("banksToLoad")] 
		public CArray<audioSoundBankStruct> BanksToLoad
		{
			get
			{
				if (_banksToLoad == null)
				{
					_banksToLoad = (CArray<audioSoundBankStruct>) CR2WTypeManager.Create("array:audioSoundBankStruct", "banksToLoad", cr2w, this);
				}
				return _banksToLoad;
			}
			set
			{
				if (_banksToLoad == value)
				{
					return;
				}
				_banksToLoad = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("banksToUnload")] 
		public CArray<audioSoundBankStruct> BanksToUnload
		{
			get
			{
				if (_banksToUnload == null)
				{
					_banksToUnload = (CArray<audioSoundBankStruct>) CR2WTypeManager.Create("array:audioSoundBankStruct", "banksToUnload", cr2w, this);
				}
				return _banksToUnload;
			}
			set
			{
				if (_banksToUnload == value)
				{
					return;
				}
				_banksToUnload = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("waitOnLoad")] 
		public CBool WaitOnLoad
		{
			get
			{
				if (_waitOnLoad == null)
				{
					_waitOnLoad = (CBool) CR2WTypeManager.Create("Bool", "waitOnLoad", cr2w, this);
				}
				return _waitOnLoad;
			}
			set
			{
				if (_waitOnLoad == value)
				{
					return;
				}
				_waitOnLoad = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		public questAudioLoadingNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
