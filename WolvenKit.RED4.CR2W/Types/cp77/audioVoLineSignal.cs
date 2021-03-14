using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoLineSignal : CVariable
	{
		private CRUID _ruid;
		private CName _signal;

		[Ordinal(0)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get
			{
				if (_ruid == null)
				{
					_ruid = (CRUID) CR2WTypeManager.Create("CRUID", "ruid", cr2w, this);
				}
				return _ruid;
			}
			set
			{
				if (_ruid == value)
				{
					return;
				}
				_ruid = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("signal")] 
		public CName Signal
		{
			get
			{
				if (_signal == null)
				{
					_signal = (CName) CR2WTypeManager.Create("CName", "signal", cr2w, this);
				}
				return _signal;
			}
			set
			{
				if (_signal == value)
				{
					return;
				}
				_signal = value;
				PropertySet(this);
			}
		}

		public audioVoLineSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
