const { spawn } = require('child_process');
const child = spawn("dotnet", ["bin/Debug/netcoreapp2.1/test.dll"], {
    detached: true,
    silent: true,
    stdio: 'pipe'
});
child.unref();
child.stdout.on('data', function(data) {
    console.log('stdout: ' + data);
});
child.stdin.write('Hello World!\r\n');
