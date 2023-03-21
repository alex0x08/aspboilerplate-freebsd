import { TestAppTemplatePage } from './app.po';

describe('TestApp App', function() {
  let page: TestAppTemplatePage;

  beforeEach(() => {
    page = new TestAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
