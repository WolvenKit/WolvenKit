using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHoldIndicatorGameController : gameuiWidgetGameController
	{
		private gameuiHoldIndicatorProgressCallback _holdProgress;
		private inkEmptyCallback _holdStart;
		private inkEmptyCallback _holdFinish;
		private inkEmptyCallback _holdStop;

		[Ordinal(2)] 
		[RED("HoldProgress")] 
		public gameuiHoldIndicatorProgressCallback HoldProgress
		{
			get
			{
				if (_holdProgress == null)
				{
					_holdProgress = (gameuiHoldIndicatorProgressCallback) CR2WTypeManager.Create("gameuiHoldIndicatorProgressCallback", "HoldProgress", cr2w, this);
				}
				return _holdProgress;
			}
			set
			{
				if (_holdProgress == value)
				{
					return;
				}
				_holdProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("HoldStart")] 
		public inkEmptyCallback HoldStart
		{
			get
			{
				if (_holdStart == null)
				{
					_holdStart = (inkEmptyCallback) CR2WTypeManager.Create("inkEmptyCallback", "HoldStart", cr2w, this);
				}
				return _holdStart;
			}
			set
			{
				if (_holdStart == value)
				{
					return;
				}
				_holdStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("HoldFinish")] 
		public inkEmptyCallback HoldFinish
		{
			get
			{
				if (_holdFinish == null)
				{
					_holdFinish = (inkEmptyCallback) CR2WTypeManager.Create("inkEmptyCallback", "HoldFinish", cr2w, this);
				}
				return _holdFinish;
			}
			set
			{
				if (_holdFinish == value)
				{
					return;
				}
				_holdFinish = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("HoldStop")] 
		public inkEmptyCallback HoldStop
		{
			get
			{
				if (_holdStop == null)
				{
					_holdStop = (inkEmptyCallback) CR2WTypeManager.Create("inkEmptyCallback", "HoldStop", cr2w, this);
				}
				return _holdStop;
			}
			set
			{
				if (_holdStop == value)
				{
					return;
				}
				_holdStop = value;
				PropertySet(this);
			}
		}

		public gameuiHoldIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
