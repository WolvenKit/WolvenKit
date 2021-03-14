using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDoorDecoratorMetadata : audioEmitterMetadata
	{
		private CName _startOpen;
		private CName _startClose;
		private CName _endOpen;
		private CName _endClose;
		private CName _openLoop;
		private CName _closeLoop;
		private CFloat _openTime;
		private CFloat _closeTime;

		[Ordinal(1)] 
		[RED("startOpen")] 
		public CName StartOpen
		{
			get
			{
				if (_startOpen == null)
				{
					_startOpen = (CName) CR2WTypeManager.Create("CName", "startOpen", cr2w, this);
				}
				return _startOpen;
			}
			set
			{
				if (_startOpen == value)
				{
					return;
				}
				_startOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startClose")] 
		public CName StartClose
		{
			get
			{
				if (_startClose == null)
				{
					_startClose = (CName) CR2WTypeManager.Create("CName", "startClose", cr2w, this);
				}
				return _startClose;
			}
			set
			{
				if (_startClose == value)
				{
					return;
				}
				_startClose = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("endOpen")] 
		public CName EndOpen
		{
			get
			{
				if (_endOpen == null)
				{
					_endOpen = (CName) CR2WTypeManager.Create("CName", "endOpen", cr2w, this);
				}
				return _endOpen;
			}
			set
			{
				if (_endOpen == value)
				{
					return;
				}
				_endOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("endClose")] 
		public CName EndClose
		{
			get
			{
				if (_endClose == null)
				{
					_endClose = (CName) CR2WTypeManager.Create("CName", "endClose", cr2w, this);
				}
				return _endClose;
			}
			set
			{
				if (_endClose == value)
				{
					return;
				}
				_endClose = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("openLoop")] 
		public CName OpenLoop
		{
			get
			{
				if (_openLoop == null)
				{
					_openLoop = (CName) CR2WTypeManager.Create("CName", "openLoop", cr2w, this);
				}
				return _openLoop;
			}
			set
			{
				if (_openLoop == value)
				{
					return;
				}
				_openLoop = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("closeLoop")] 
		public CName CloseLoop
		{
			get
			{
				if (_closeLoop == null)
				{
					_closeLoop = (CName) CR2WTypeManager.Create("CName", "closeLoop", cr2w, this);
				}
				return _closeLoop;
			}
			set
			{
				if (_closeLoop == value)
				{
					return;
				}
				_closeLoop = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("openTime")] 
		public CFloat OpenTime
		{
			get
			{
				if (_openTime == null)
				{
					_openTime = (CFloat) CR2WTypeManager.Create("Float", "openTime", cr2w, this);
				}
				return _openTime;
			}
			set
			{
				if (_openTime == value)
				{
					return;
				}
				_openTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("closeTime")] 
		public CFloat CloseTime
		{
			get
			{
				if (_closeTime == null)
				{
					_closeTime = (CFloat) CR2WTypeManager.Create("Float", "closeTime", cr2w, this);
				}
				return _closeTime;
			}
			set
			{
				if (_closeTime == value)
				{
					return;
				}
				_closeTime = value;
				PropertySet(this);
			}
		}

		public audioDoorDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
