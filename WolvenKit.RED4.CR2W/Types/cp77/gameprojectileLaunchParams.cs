using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileLaunchParams : CVariable
	{
		private CEnum<gameprojectileELaunchMode> _launchMode;
		private CHandle<entIPositionProvider> _logicalPositionProvider;
		private CHandle<entIOrientationProvider> _logicalOrientationProvider;
		private CHandle<entIPositionProvider> _visualPositionProvider;
		private CHandle<entIOrientationProvider> _visualOrientationProvider;
		private CHandle<entIVelocityProvider> _ownerVelocityProvider;

		[Ordinal(0)] 
		[RED("launchMode")] 
		public CEnum<gameprojectileELaunchMode> LaunchMode
		{
			get
			{
				if (_launchMode == null)
				{
					_launchMode = (CEnum<gameprojectileELaunchMode>) CR2WTypeManager.Create("gameprojectileELaunchMode", "launchMode", cr2w, this);
				}
				return _launchMode;
			}
			set
			{
				if (_launchMode == value)
				{
					return;
				}
				_launchMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("logicalPositionProvider")] 
		public CHandle<entIPositionProvider> LogicalPositionProvider
		{
			get
			{
				if (_logicalPositionProvider == null)
				{
					_logicalPositionProvider = (CHandle<entIPositionProvider>) CR2WTypeManager.Create("handle:entIPositionProvider", "logicalPositionProvider", cr2w, this);
				}
				return _logicalPositionProvider;
			}
			set
			{
				if (_logicalPositionProvider == value)
				{
					return;
				}
				_logicalPositionProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("logicalOrientationProvider")] 
		public CHandle<entIOrientationProvider> LogicalOrientationProvider
		{
			get
			{
				if (_logicalOrientationProvider == null)
				{
					_logicalOrientationProvider = (CHandle<entIOrientationProvider>) CR2WTypeManager.Create("handle:entIOrientationProvider", "logicalOrientationProvider", cr2w, this);
				}
				return _logicalOrientationProvider;
			}
			set
			{
				if (_logicalOrientationProvider == value)
				{
					return;
				}
				_logicalOrientationProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("visualPositionProvider")] 
		public CHandle<entIPositionProvider> VisualPositionProvider
		{
			get
			{
				if (_visualPositionProvider == null)
				{
					_visualPositionProvider = (CHandle<entIPositionProvider>) CR2WTypeManager.Create("handle:entIPositionProvider", "visualPositionProvider", cr2w, this);
				}
				return _visualPositionProvider;
			}
			set
			{
				if (_visualPositionProvider == value)
				{
					return;
				}
				_visualPositionProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("visualOrientationProvider")] 
		public CHandle<entIOrientationProvider> VisualOrientationProvider
		{
			get
			{
				if (_visualOrientationProvider == null)
				{
					_visualOrientationProvider = (CHandle<entIOrientationProvider>) CR2WTypeManager.Create("handle:entIOrientationProvider", "visualOrientationProvider", cr2w, this);
				}
				return _visualOrientationProvider;
			}
			set
			{
				if (_visualOrientationProvider == value)
				{
					return;
				}
				_visualOrientationProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ownerVelocityProvider")] 
		public CHandle<entIVelocityProvider> OwnerVelocityProvider
		{
			get
			{
				if (_ownerVelocityProvider == null)
				{
					_ownerVelocityProvider = (CHandle<entIVelocityProvider>) CR2WTypeManager.Create("handle:entIVelocityProvider", "ownerVelocityProvider", cr2w, this);
				}
				return _ownerVelocityProvider;
			}
			set
			{
				if (_ownerVelocityProvider == value)
				{
					return;
				}
				_ownerVelocityProvider = value;
				PropertySet(this);
			}
		}

		public gameprojectileLaunchParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
