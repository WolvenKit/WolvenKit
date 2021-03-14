using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JukeboxSetup : CVariable
	{
		private CEnum<ERadioStationList> _startingStation;
		private CName _glitchSFX;
		private TweakDBID _paymentRecordID;

		[Ordinal(0)] 
		[RED("startingStation")] 
		public CEnum<ERadioStationList> StartingStation
		{
			get
			{
				if (_startingStation == null)
				{
					_startingStation = (CEnum<ERadioStationList>) CR2WTypeManager.Create("ERadioStationList", "startingStation", cr2w, this);
				}
				return _startingStation;
			}
			set
			{
				if (_startingStation == value)
				{
					return;
				}
				_startingStation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get
			{
				if (_glitchSFX == null)
				{
					_glitchSFX = (CName) CR2WTypeManager.Create("CName", "glitchSFX", cr2w, this);
				}
				return _glitchSFX;
			}
			set
			{
				if (_glitchSFX == value)
				{
					return;
				}
				_glitchSFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("paymentRecordID")] 
		public TweakDBID PaymentRecordID
		{
			get
			{
				if (_paymentRecordID == null)
				{
					_paymentRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "paymentRecordID", cr2w, this);
				}
				return _paymentRecordID;
			}
			set
			{
				if (_paymentRecordID == value)
				{
					return;
				}
				_paymentRecordID = value;
				PropertySet(this);
			}
		}

		public JukeboxSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
