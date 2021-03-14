using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetDrivenKey_InternalsEntry : CVariable
	{
		private curveData<CFloat> _curve;
		private CName _inChannelName;
		private CName _outChannelName;
		private CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> _inChanelType;
		private CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> _outChanelType;

		[Ordinal(0)] 
		[RED("curve")] 
		public curveData<CFloat> Curve
		{
			get
			{
				if (_curve == null)
				{
					_curve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "curve", cr2w, this);
				}
				return _curve;
			}
			set
			{
				if (_curve == value)
				{
					return;
				}
				_curve = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inChannelName")] 
		public CName InChannelName
		{
			get
			{
				if (_inChannelName == null)
				{
					_inChannelName = (CName) CR2WTypeManager.Create("CName", "inChannelName", cr2w, this);
				}
				return _inChannelName;
			}
			set
			{
				if (_inChannelName == value)
				{
					return;
				}
				_inChannelName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outChannelName")] 
		public CName OutChannelName
		{
			get
			{
				if (_outChannelName == null)
				{
					_outChannelName = (CName) CR2WTypeManager.Create("CName", "outChannelName", cr2w, this);
				}
				return _outChannelName;
			}
			set
			{
				if (_outChannelName == value)
				{
					return;
				}
				_outChannelName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inChanelType")] 
		public CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> InChanelType
		{
			get
			{
				if (_inChanelType == null)
				{
					_inChanelType = (CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType>) CR2WTypeManager.Create("animAnimNode_SetDrivenKey_InternalsEChannelType", "inChanelType", cr2w, this);
				}
				return _inChanelType;
			}
			set
			{
				if (_inChanelType == value)
				{
					return;
				}
				_inChanelType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("outChanelType")] 
		public CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> OutChanelType
		{
			get
			{
				if (_outChanelType == null)
				{
					_outChanelType = (CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType>) CR2WTypeManager.Create("animAnimNode_SetDrivenKey_InternalsEChannelType", "outChanelType", cr2w, this);
				}
				return _outChanelType;
			}
			set
			{
				if (_outChanelType == value)
				{
					return;
				}
				_outChanelType = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SetDrivenKey_InternalsEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
