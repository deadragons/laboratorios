const httpFunction = require('./index');
const context = require('../testing/context');

test('Http trigger example', async() => {
    const request = {
        query: { name: 'Alberto' }
    };

    await httpFunction(context, request);
    expect(context.res.body).toEqual('Welcome, Alberto');
    expect(context.log.mock.calls.length).toBe(1);
});