using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimPlaybackOptions : CVariable
	{
		private CBool _playReversed;
		private CEnum<inkanimLoopType> _loopType;
		private CUInt32 _loopCounter;
		private CFloat _executionDelay;
		private CBool _loopInfinite;
		private CName _fromMarker;
		private CName _toMarker;
		private CBool _oneSegment;
		private CBool _dependsOnTimeDilation;

		[Ordinal(0)] 
		[RED("playReversed")] 
		public CBool PlayReversed
		{
			get
			{
				if (_playReversed == null)
				{
					_playReversed = (CBool) CR2WTypeManager.Create("Bool", "playReversed", cr2w, this);
				}
				return _playReversed;
			}
			set
			{
				if (_playReversed == value)
				{
					return;
				}
				_playReversed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("loopType")] 
		public CEnum<inkanimLoopType> LoopType
		{
			get
			{
				if (_loopType == null)
				{
					_loopType = (CEnum<inkanimLoopType>) CR2WTypeManager.Create("inkanimLoopType", "loopType", cr2w, this);
				}
				return _loopType;
			}
			set
			{
				if (_loopType == value)
				{
					return;
				}
				_loopType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("loopCounter")] 
		public CUInt32 LoopCounter
		{
			get
			{
				if (_loopCounter == null)
				{
					_loopCounter = (CUInt32) CR2WTypeManager.Create("Uint32", "loopCounter", cr2w, this);
				}
				return _loopCounter;
			}
			set
			{
				if (_loopCounter == value)
				{
					return;
				}
				_loopCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("executionDelay")] 
		public CFloat ExecutionDelay
		{
			get
			{
				if (_executionDelay == null)
				{
					_executionDelay = (CFloat) CR2WTypeManager.Create("Float", "executionDelay", cr2w, this);
				}
				return _executionDelay;
			}
			set
			{
				if (_executionDelay == value)
				{
					return;
				}
				_executionDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("loopInfinite")] 
		public CBool LoopInfinite
		{
			get
			{
				if (_loopInfinite == null)
				{
					_loopInfinite = (CBool) CR2WTypeManager.Create("Bool", "loopInfinite", cr2w, this);
				}
				return _loopInfinite;
			}
			set
			{
				if (_loopInfinite == value)
				{
					return;
				}
				_loopInfinite = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fromMarker")] 
		public CName FromMarker
		{
			get
			{
				if (_fromMarker == null)
				{
					_fromMarker = (CName) CR2WTypeManager.Create("CName", "fromMarker", cr2w, this);
				}
				return _fromMarker;
			}
			set
			{
				if (_fromMarker == value)
				{
					return;
				}
				_fromMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("toMarker")] 
		public CName ToMarker
		{
			get
			{
				if (_toMarker == null)
				{
					_toMarker = (CName) CR2WTypeManager.Create("CName", "toMarker", cr2w, this);
				}
				return _toMarker;
			}
			set
			{
				if (_toMarker == value)
				{
					return;
				}
				_toMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("oneSegment")] 
		public CBool OneSegment
		{
			get
			{
				if (_oneSegment == null)
				{
					_oneSegment = (CBool) CR2WTypeManager.Create("Bool", "oneSegment", cr2w, this);
				}
				return _oneSegment;
			}
			set
			{
				if (_oneSegment == value)
				{
					return;
				}
				_oneSegment = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("dependsOnTimeDilation")] 
		public CBool DependsOnTimeDilation
		{
			get
			{
				if (_dependsOnTimeDilation == null)
				{
					_dependsOnTimeDilation = (CBool) CR2WTypeManager.Create("Bool", "dependsOnTimeDilation", cr2w, this);
				}
				return _dependsOnTimeDilation;
			}
			set
			{
				if (_dependsOnTimeDilation == value)
				{
					return;
				}
				_dependsOnTimeDilation = value;
				PropertySet(this);
			}
		}

		public inkanimPlaybackOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
