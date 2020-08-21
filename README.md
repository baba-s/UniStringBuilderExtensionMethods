# UniStringBuilderExtensionMethods

StringBuilder 型の拡張メソッド

## AppendLine

```cs
using Kogane;
using System.Text;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        var builder = new StringBuilder();

        // AppendLine で書式指定が可能になります
        builder.AppendLine( "{0}", 1 );
        builder.AppendLine( "{0}, {1}", 1, 2 );
        builder.AppendLine( "{0}, {1}, {2}", 1, 2, 3 );

        Debug.Log( builder.ToString() );
    }
}
```
