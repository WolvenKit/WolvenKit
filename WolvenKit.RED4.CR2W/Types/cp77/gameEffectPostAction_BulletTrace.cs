using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_BulletTrace : gameEffectPostAction_BeamVFX
	{

		public gameEffectPostAction_BulletTrace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
