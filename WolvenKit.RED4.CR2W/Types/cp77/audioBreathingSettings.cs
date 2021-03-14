using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioBreathingSettings : audioAudioMetadata
	{
		private CName _exhaustionRtpc;
		private CName _idleFadeOutRtpc;
		private CName _initialState;

		[Ordinal(1)] 
		[RED("exhaustionRtpc")] 
		public CName ExhaustionRtpc
		{
			get
			{
				if (_exhaustionRtpc == null)
				{
					_exhaustionRtpc = (CName) CR2WTypeManager.Create("CName", "exhaustionRtpc", cr2w, this);
				}
				return _exhaustionRtpc;
			}
			set
			{
				if (_exhaustionRtpc == value)
				{
					return;
				}
				_exhaustionRtpc = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("idleFadeOutRtpc")] 
		public CName IdleFadeOutRtpc
		{
			get
			{
				if (_idleFadeOutRtpc == null)
				{
					_idleFadeOutRtpc = (CName) CR2WTypeManager.Create("CName", "idleFadeOutRtpc", cr2w, this);
				}
				return _idleFadeOutRtpc;
			}
			set
			{
				if (_idleFadeOutRtpc == value)
				{
					return;
				}
				_idleFadeOutRtpc = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("initialState")] 
		public CName InitialState
		{
			get
			{
				if (_initialState == null)
				{
					_initialState = (CName) CR2WTypeManager.Create("CName", "initialState", cr2w, this);
				}
				return _initialState;
			}
			set
			{
				if (_initialState == value)
				{
					return;
				}
				_initialState = value;
				PropertySet(this);
			}
		}

		public audioBreathingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
