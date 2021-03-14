using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DrillMachineScanManager : gameScriptableComponent
	{
		private CBool _ppStarting;
		private CBool _ppEnding;
		private CFloat _ppCurrentStartTime;
		private CInt32 _ppCurrentEndFrame;
		private CFloat _idleToScanTime;
		private CInt32 _ppOffFrameDelay;

		[Ordinal(5)] 
		[RED("ppStarting")] 
		public CBool PpStarting
		{
			get
			{
				if (_ppStarting == null)
				{
					_ppStarting = (CBool) CR2WTypeManager.Create("Bool", "ppStarting", cr2w, this);
				}
				return _ppStarting;
			}
			set
			{
				if (_ppStarting == value)
				{
					return;
				}
				_ppStarting = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ppEnding")] 
		public CBool PpEnding
		{
			get
			{
				if (_ppEnding == null)
				{
					_ppEnding = (CBool) CR2WTypeManager.Create("Bool", "ppEnding", cr2w, this);
				}
				return _ppEnding;
			}
			set
			{
				if (_ppEnding == value)
				{
					return;
				}
				_ppEnding = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ppCurrentStartTime")] 
		public CFloat PpCurrentStartTime
		{
			get
			{
				if (_ppCurrentStartTime == null)
				{
					_ppCurrentStartTime = (CFloat) CR2WTypeManager.Create("Float", "ppCurrentStartTime", cr2w, this);
				}
				return _ppCurrentStartTime;
			}
			set
			{
				if (_ppCurrentStartTime == value)
				{
					return;
				}
				_ppCurrentStartTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ppCurrentEndFrame")] 
		public CInt32 PpCurrentEndFrame
		{
			get
			{
				if (_ppCurrentEndFrame == null)
				{
					_ppCurrentEndFrame = (CInt32) CR2WTypeManager.Create("Int32", "ppCurrentEndFrame", cr2w, this);
				}
				return _ppCurrentEndFrame;
			}
			set
			{
				if (_ppCurrentEndFrame == value)
				{
					return;
				}
				_ppCurrentEndFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("idleToScanTime")] 
		public CFloat IdleToScanTime
		{
			get
			{
				if (_idleToScanTime == null)
				{
					_idleToScanTime = (CFloat) CR2WTypeManager.Create("Float", "idleToScanTime", cr2w, this);
				}
				return _idleToScanTime;
			}
			set
			{
				if (_idleToScanTime == value)
				{
					return;
				}
				_idleToScanTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ppOffFrameDelay")] 
		public CInt32 PpOffFrameDelay
		{
			get
			{
				if (_ppOffFrameDelay == null)
				{
					_ppOffFrameDelay = (CInt32) CR2WTypeManager.Create("Int32", "ppOffFrameDelay", cr2w, this);
				}
				return _ppOffFrameDelay;
			}
			set
			{
				if (_ppOffFrameDelay == value)
				{
					return;
				}
				_ppOffFrameDelay = value;
				PropertySet(this);
			}
		}

		public DrillMachineScanManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
