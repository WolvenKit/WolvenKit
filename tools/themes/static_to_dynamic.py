"""Replace {StaticResource <theme color key>} with {DynamicResource ...} in WolvenKit XAML.

Skips:
- attributes on Freezable elements (brushes, gradient stops, pens, effects, animations): a Freezable with a
  DynamicResource can't be frozen, which breaks sealed styles and app-level resources. Their source values are
  replaced by the theme service anyway.
- BasedOn / Style / Template / TargetType attributes and anything inside a markup extension (ConverterParameter=...).
- RDTMeshView.xaml (mesh preview work in progress on another branch).
"""
import json, re, sys, pathlib, collections

root = pathlib.Path(sys.argv[1])
dry = len(sys.argv) > 2 and sys.argv[2] == '--dry'

entries = json.load(open(root / 'WolvenKit.App/Resources/Themes/theme-keys.json'))['entries']
keys = {e['key'] for e in entries}
for e in entries:
    keys.update(e.get('derivedBrushes') or [])
PREFIXES = ('ContentBackground', 'ContentForeground', 'BorderAlt', 'Popup', 'IconColor', 'MahApps.Brushes.',
            'PrimaryBackground', 'PrimaryForeground', 'HoveredBackground', 'SelectedBackground', 'PressedBackground')

def is_theme_key(k):
    return k in keys or k.startswith(PREFIXES)

FREEZABLE = {'SolidColorBrush', 'LinearGradientBrush', 'RadialGradientBrush', 'GradientStop', 'Pen',
             'DropShadowEffect', 'BlurEffect', 'ColorAnimation', 'ColorAnimationUsingKeyFrames',
             'LinearColorKeyFrame', 'DiscreteColorKeyFrame', 'EasingColorKeyFrame', 'DrawingBrush',
             'GeometryDrawing', 'VisualBrush', 'ImageBrush'}
SKIP_ATTR = {'BasedOn', 'Style', 'Template', 'TargetType', 'ItemContainerStyle', 'ContentTemplate'}

attr_rx = re.compile(r'(?P<pre>\s)(?P<attr>[\w:.]+)="\{StaticResource\s+(?P<key>[\w.]+)\s*\}"')
tag_rx = re.compile(r'<(?P<name>[\w:.]+)')

stats = collections.Counter(); skipped = collections.Counter(); pairs = collections.Counter(); changed_files = 0
for f in root.joinpath('WolvenKit').rglob('*.xaml'):
    if f.name == 'RDTMeshView.xaml' or 'obj' in f.parts or 'bin' in f.parts:
        continue
    text = f.read_text(encoding='utf-8')
    parts = re.split(r'(<!--.*?-->)', text, flags=re.S)
    n = 0
    for i, part in enumerate(parts):
        if part.startswith('<!--'):
            continue
        def repl(m):
            global n
            key, attr = m.group('key'), m.group('attr')
            if not is_theme_key(key):
                return m.group(0)
            start = part.rfind('<', 0, m.start())
            tag = tag_rx.match(part, start)
            name = tag.group('name').split(':')[-1] if tag else '?'
            if attr in SKIP_ATTR:
                skipped['attr ' + attr] += 1; return m.group(0)
            if name == 'ThemeResources':  # HandyControl ResourceDictionary, plain CLR properties
                skipped['ThemeResources.' + attr] += 1; return m.group(0)
            if name in FREEZABLE:
                skipped['freezable ' + name] += 1; return m.group(0)
            pairs[(tag.group('name') if tag else '?', attr)] += 1
            n_list.append(1)
            return f'{m.group("pre")}{attr}="{{DynamicResource {key}}}"'
        n_list = []
        parts[i] = attr_rx.sub(repl, part)
        n += len(n_list)
    if n:
        changed_files += 1; stats['refs'] += n
        if not dry:
            f.write_text(''.join(parts), encoding='utf-8')

print('replaced', stats['refs'], 'in', changed_files, 'files')
print('skipped', dict(skipped))
print('distinct (element, attribute):')
for (el, at), c in sorted(pairs.items(), key=lambda x: -x[1]):
    print(f'  {c:4} {el}.{at}')
