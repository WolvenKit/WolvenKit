using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitDetectionDebugFrameData : CVariable
	{
		private CBool _t;
		private wCHandle<gameHitRepresentationComponent> _mponent;
		private netTime _tTime;
		private CArray<gameHitDetectionDebugFrameDataShapeEntry> _apes;

		[Ordinal(0)] 
		[RED("t")] 
		public CBool T
		{
			get
			{
				if (_t == null)
				{
					_t = (CBool) CR2WTypeManager.Create("Bool", "t", cr2w, this);
				}
				return _t;
			}
			set
			{
				if (_t == value)
				{
					return;
				}
				_t = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mponent")] 
		public wCHandle<gameHitRepresentationComponent> Mponent
		{
			get
			{
				if (_mponent == null)
				{
					_mponent = (wCHandle<gameHitRepresentationComponent>) CR2WTypeManager.Create("whandle:gameHitRepresentationComponent", "mponent", cr2w, this);
				}
				return _mponent;
			}
			set
			{
				if (_mponent == value)
				{
					return;
				}
				_mponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tTime")] 
		public netTime TTime
		{
			get
			{
				if (_tTime == null)
				{
					_tTime = (netTime) CR2WTypeManager.Create("netTime", "tTime", cr2w, this);
				}
				return _tTime;
			}
			set
			{
				if (_tTime == value)
				{
					return;
				}
				_tTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("apes")] 
		public CArray<gameHitDetectionDebugFrameDataShapeEntry> Apes
		{
			get
			{
				if (_apes == null)
				{
					_apes = (CArray<gameHitDetectionDebugFrameDataShapeEntry>) CR2WTypeManager.Create("array:gameHitDetectionDebugFrameDataShapeEntry", "apes", cr2w, this);
				}
				return _apes;
			}
			set
			{
				if (_apes == value)
				{
					return;
				}
				_apes = value;
				PropertySet(this);
			}
		}

		public gameHitDetectionDebugFrameData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
