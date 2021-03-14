using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiVOWithDelay : CVariable
	{
		private CFloat _playDelay;
		private CString _voHexID;

		[Ordinal(0)] 
		[RED("playDelay")] 
		public CFloat PlayDelay
		{
			get
			{
				if (_playDelay == null)
				{
					_playDelay = (CFloat) CR2WTypeManager.Create("Float", "playDelay", cr2w, this);
				}
				return _playDelay;
			}
			set
			{
				if (_playDelay == value)
				{
					return;
				}
				_playDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("voHexID")] 
		public CString VoHexID
		{
			get
			{
				if (_voHexID == null)
				{
					_voHexID = (CString) CR2WTypeManager.Create("String", "voHexID", cr2w, this);
				}
				return _voHexID;
			}
			set
			{
				if (_voHexID == value)
				{
					return;
				}
				_voHexID = value;
				PropertySet(this);
			}
		}

		public gameuiVOWithDelay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
