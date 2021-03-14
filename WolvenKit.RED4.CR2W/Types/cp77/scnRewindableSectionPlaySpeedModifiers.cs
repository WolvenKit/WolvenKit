using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRewindableSectionPlaySpeedModifiers : CVariable
	{
		private CFloat _forwardVeryFast;
		private CFloat _forwardFast;
		private CFloat _forwardSlow;
		private CFloat _backwardVeryFast;
		private CFloat _backwardFast;
		private CFloat _backwardSlow;

		[Ordinal(0)] 
		[RED("forwardVeryFast")] 
		public CFloat ForwardVeryFast
		{
			get
			{
				if (_forwardVeryFast == null)
				{
					_forwardVeryFast = (CFloat) CR2WTypeManager.Create("Float", "forwardVeryFast", cr2w, this);
				}
				return _forwardVeryFast;
			}
			set
			{
				if (_forwardVeryFast == value)
				{
					return;
				}
				_forwardVeryFast = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("forwardFast")] 
		public CFloat ForwardFast
		{
			get
			{
				if (_forwardFast == null)
				{
					_forwardFast = (CFloat) CR2WTypeManager.Create("Float", "forwardFast", cr2w, this);
				}
				return _forwardFast;
			}
			set
			{
				if (_forwardFast == value)
				{
					return;
				}
				_forwardFast = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("forwardSlow")] 
		public CFloat ForwardSlow
		{
			get
			{
				if (_forwardSlow == null)
				{
					_forwardSlow = (CFloat) CR2WTypeManager.Create("Float", "forwardSlow", cr2w, this);
				}
				return _forwardSlow;
			}
			set
			{
				if (_forwardSlow == value)
				{
					return;
				}
				_forwardSlow = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("backwardVeryFast")] 
		public CFloat BackwardVeryFast
		{
			get
			{
				if (_backwardVeryFast == null)
				{
					_backwardVeryFast = (CFloat) CR2WTypeManager.Create("Float", "backwardVeryFast", cr2w, this);
				}
				return _backwardVeryFast;
			}
			set
			{
				if (_backwardVeryFast == value)
				{
					return;
				}
				_backwardVeryFast = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("backwardFast")] 
		public CFloat BackwardFast
		{
			get
			{
				if (_backwardFast == null)
				{
					_backwardFast = (CFloat) CR2WTypeManager.Create("Float", "backwardFast", cr2w, this);
				}
				return _backwardFast;
			}
			set
			{
				if (_backwardFast == value)
				{
					return;
				}
				_backwardFast = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("backwardSlow")] 
		public CFloat BackwardSlow
		{
			get
			{
				if (_backwardSlow == null)
				{
					_backwardSlow = (CFloat) CR2WTypeManager.Create("Float", "backwardSlow", cr2w, this);
				}
				return _backwardSlow;
			}
			set
			{
				if (_backwardSlow == value)
				{
					return;
				}
				_backwardSlow = value;
				PropertySet(this);
			}
		}

		public scnRewindableSectionPlaySpeedModifiers(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
